using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PopupMessage
{
    public class Class_frmMain
    {
        #region Constants

        public static string SourceIsChanged    => "Відбулися зміни в таблиці. Будете зберігати?";
        public static string Saving => "Збереження даних..";

        #endregion

        #region Variables

        public BindingList<clsSource> Source { get; set; }
        public List<string> EventSource { get; set; }
        public List<clsSource> AlertSource { get; set; }

        string pathToDataFile = "data.xml";
        string pathToEventFile = "events.xml";

        #endregion

        #region Init

        public Class_frmMain()
        {
            Source = new BindingList<clsSource>();
            EventSource = new List<string>();
            AlertSource = new List<clsSource>();
        }

        #endregion

        #region Load data

        public bool LoadData(out string Message)
        {
            Message = "ok";

            if (!File.Exists(pathToEventFile))
            {
                Message = "error";

                return false;
            }

            GetEventSource();

            Source.Clear();

            if (!File.Exists(pathToDataFile))
            {
                Message = "error";

                return false;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(pathToDataFile);

            BindingList<clsSource> Items = new BindingList<clsSource>();

            foreach (var lineXml in doc.DocumentElement.ChildNodes)
            {
                clsSource item = new clsSource();

                item.ID = int.Parse((((XmlNode)lineXml).ChildNodes)[0].InnerText);
                item.Person = ((XmlNode)lineXml).ChildNodes[1].InnerText;
                item.Event = ((XmlNode)lineXml).ChildNodes[2].InnerText;
                item.Comment = ((XmlNode)lineXml).ChildNodes[3].InnerText;
                item.On_Date = Convert.ToDateTime(((XmlNode)lineXml).ChildNodes[4].InnerText);
                item.Sort = (((XmlNode)lineXml).ChildNodes)[5].InnerText;

                item.isAdded = false;
                item.isChanged = false;

                Items.Add(item);
            }

            OrderSource(Items);

            SaveSourceState();

            PrepareAlertSource();

            return true;
        }

        #endregion

        #region Save data

        public bool SaveData(out string Message)
        {
            Message = "ok";

            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Person");
            dt.Columns.Add("Event");
            dt.Columns.Add("Comment");
            dt.Columns.Add("On_date");
            dt.Columns.Add("Sort");

            var last_id = Source.Select(r => r.ID).Max();

            foreach (var item in Source)
            {
                if (item.ID == 0)
                    item.ID = ++last_id;

                //if (item.Sort.IsNullOrEmpty())
                {
                    string day = item.On_Date.Day < 10 ? $"0{item.On_Date.Day}" : $"{item.On_Date.Day}";
                    string month = item.On_Date.Month < 10 ? $"0{item.On_Date.Month}" : $"{item.On_Date.Month}";

                    item.Sort = $"{month}{day}";
                }

                dt.Rows.Add(item.ID, 
                            item.Person.IsFull() ? item.Person : " ", 
                            item.Event.IsFull() ? item.Event : " ", 
                            item.Comment.IsFull() ? item.Comment : " ", 
                            item.On_Date,
                            item.Sort);
            }

            try
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                //Finally the save part:
                XmlTextWriter xmlSave = new XmlTextWriter(pathToDataFile, Encoding.UTF8);
                xmlSave.Formatting = System.Xml.Formatting.Indented;
                ds.DataSetName = "Events";
                ds.WriteXml(xmlSave);
                xmlSave.Close();
            }
            catch (Exception ex)
            {
                Message = ex.Message;

                return false;
            }

            SaveSourceState();

            return true;
        }

        #endregion

        #region Routines

        public void GetEventSource()
        {
            EventSource.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(pathToEventFile);

            foreach (var lineXml in doc.DocumentElement.ChildNodes)
            {
                EventSource.Add(((XmlNode)lineXml).ChildNodes[0].InnerText);
            }

            foreach (var item in Source.Select(r => r.Event).Distinct())
            {
                if (!EventSource.Contains(item))
                    EventSource.Add(item);
            }
        }

        public void OrderSource(BindingList<clsSource> Items)
        {
            Source = new BindingList<clsSource>(Items.OrderBy(x => x.Sort).ThenBy(r => r.On_Date).ToList());
        }

        private void PrepareAlertSource()
        {
            var items = Source.Where(r => r.On_Date.Month == DateTime.Now.Month && r.On_Date.Day == DateTime.Now.Day || 
                                    (r.On_Date.Month == DateTime.Now.AddDays(1).Month && r.On_Date.Day == DateTime.Now.AddDays(1).Day));

            AlertSource.Clear();

            AlertSource.AddRange(items);
        }

        #endregion

        #region HashCode

        private int savedSourceState = 0;
        private int SourceHash
        {
            get
            {
                var template = $"{String.Join(";", Source.Select(r => $"{String.Join(",", r.ItemsArray.ToList())}"))}";

                return template.GetHashCode();
            }
        }

        public bool IsSourceChanged => (savedSourceState != SourceHash);

        public void SaveSourceState()
        {
            savedSourceState = SourceHash;
        }

        #endregion
    }
}
