using System;
using System.Diagnostics.Eventing.Reader;

namespace HebrewDate
{
    internal partial class Form1 : Form
    {
        private XmlService _service;
        public Form1(XmlService service)
        {
            InitializeComponent();
            LoadCombobox();
            _service = service;
        }

        Dictionary<string, string> Days = new Dictionary<string, string>
        {
            {"ראשון", "באחד בשבת "},
            {"שני", "בשני בשבת "},
            { "שלישי", "בשלישי בשבת "},
            { "רביעי", "ברביעי בשבת "},
            { "חמישי", "בחמישי בשבת "},
            {"ששי", "בששי בשבת "}
        };
        Dictionary<int, string> DaysMonth = new Dictionary<int, string>
        {
            {1,"יום אחד לירח "},
            {2 , "שני ימים לירח "},
            {3, "שלשה ימים לירח "},
            {4 , "ארבעה ימים לירח "},
            {5 , "חמשה ימים לירח "},
            {6 , "ששה ימים לירח "},
            {7 , "שבעה ימים לירח "},
            {8 , "שמנה ימים לירח "},
            {9 , "תשעה ימים לירח "},
            {10, "עשרה ימים לירח "},
            {11, "אחד עשר יום לירח "},
            {12 , "שנים עשר יום לירח "},
            {13 , "שלשה עשר יום לירח "},
            {14 , "ארבעה עשר יום לירח "},
            {15 , "חמשה עשר יום לירח "},
            {16 ," ששה עשר יום לירח "},
            {17, "שבעה עשר יום לירח "},
            {18 , "שמנה עשר יום לירח "},
            {19 , "תשעה עשר יום לירח "},
            {20 , "עשרים יום לירח "},
            {21 , "אחד ועשרים יום לירח "},
            {22 ,"שנים ועשרים יום לירח "},
            {23 ,"שלשה ועשרים יום לירח "},
            {24 ,"ארבעה ועשרים יום לירח "},
            {25 ,"חמשה ועשרים יום לירח "},
            {26 ,"ששה ועשרים יום לירח "},
            {27 ,"שבעה ועשרים יום לירח "},
            {28 ,"שמנה ועשרים יום לירח "},
            {29,"תשעה ועשרים יום לירח "},
            {30, "יום שלשים"}
        };

        List<string> Months = new List<string>{ "תשרי", "מרחשון", "כסלו", "טבת", "שבט",
                                        "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"};
        Dictionary<string, string> Years = new Dictionary<string, string>
        {
            { "תשפ\"ד", "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"},
            {"תשפ\"ה", "בשנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם"},
            { "תשפ\"ו", "בשנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם"},
            { "תשפ\"ז", "בשנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העןלם"},
            { "תשפ\"ח", "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם"},
            { "תשפ\"ט", "בשנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם"},
            { "תש\"צ", "בשנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם"},
            { "תשצ\"א", "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם"},
            { "תשצ\"ב", "בשנת חמשת אלפים ושבע מאות ותשעים ושתיים לבריאת העולם"},
            {"תשצ\"ג",  "בשנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם"}
        };

        

        public void LoadCombobox()
        {
            foreach (string key in Days.Keys)
            {
                comboBoxDay.Items.Add(key);
            };
            foreach (int key in DaysMonth.Keys)
            {
                comboBoxDayInMonth.Items.Add(key);
            };
            foreach (string month in Months)
            {
                comboBoxMonth.Items.Add(month);
            };
            foreach (string key in Years.Keys)
            {
                comboBoxYear.Items.Add(key);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxDay.SelectedItem == null || comboBoxDayInMonth.SelectedItem == null 
                || comboBoxMonth.SelectedItem == null || comboBoxYear.SelectedItem == null)
            { MessageBox.Show("לא מילאת את כל התאריך"); }
            else {
                string day = comboBoxDay.SelectedItem.ToString();
                int dayInMonth = (int)comboBoxDayInMonth.SelectedItem;
                string month = comboBoxMonth.SelectedItem.ToString();
                string year = comboBoxYear.SelectedItem.ToString();
                string result;
                if (dayInMonth == 30)
                {
                    string FirstMonth = "";
                    if (Months.IndexOf(month) == 13)
                    {
                        FirstMonth = $"יום שלשים לחדש {month} שהוא ראש חודש {Months[1]}";
                    }
                    else if (Months.IndexOf(month) == 5)
                    {
                        FirstMonth = $"יום שלשים לחדש {month} שהוא ראש חודש {Months[8]}";
                    }
                    else
                    {
                        FirstMonth = $"יום שלשים לחדש {month} שהוא ראש חודש {Months[Months.IndexOf(month) + 1]}";
                    }
                    result = $" {Days[day]} {FirstMonth} {Years[year]}".Trim();
                }
                else
                {
                    result = $" {Days[day]}{DaysMonth[dayInMonth]}{month} {Years[year]}".Trim();
                }
                MessageBox.Show(result);
                HebrewDateModel dateNodel = new HebrewDateModel(day, dayInMonth.ToString(), month, year, result);
                _service.Add(dateNodel);
            }
            
        }
    }


}
