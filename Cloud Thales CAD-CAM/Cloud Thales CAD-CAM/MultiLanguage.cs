using System;
using System.Linq;
using System.ComponentModel;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cloud_Thales_CAD_CAM
{
    public partial class MultiLanguage : Component
    {
        public static XDocument alpXdocument;
        public static XDocument errors = new XDocument();

        #region Init(default constructor) / Init(constructor with param)
        public MultiLanguage(string alpFile = "")
        {
            InitializeComponent();

            alpXdocument = LoadAlp(alpFile);
            errors = XDocument.Parse(alpXdocument.Root.Element("ErrorCodes").ToString());
        }

        public MultiLanguage(IContainer container, string alpFile = "")
        {
            container.Add(this);

            InitializeComponent();

            alpXdocument = LoadAlp(alpFile);
            errors = XDocument.Parse(alpXdocument.Root.Element("ErrorCodes").ToString());
        }
        #endregion

        #region Methods: Set/Reset Language
        public bool SetLanguage(string languageCode, Control.ControlCollection cCollections, Form currentForm)
        {
            if (alpXdocument != null)
            {
                foreach (XElement el in alpXdocument.Root.Elements())
                {
                    foreach (var el2 in el.Elements("language"))
                    {
                        if (Convert.ToString(el.Name).Contains("Form"))
                        {
                            if (currentForm.Name == el.Name)
                            {
                                if (el2.Attribute("name").Value == languageCode)
                                {
                                    currentForm.Text = el2.Value;
                                    break;
                                }
                            }
                        }

                        foreach (Control c in cCollections)
                        {
                            if (c.Name.Contains("tabControl"))
                            {
                                foreach (Control p in c.Controls)
                                {
                                    foreach (Control e in p.Controls)
                                    {
                                        if (e.Name == el.Name)
                                        {
                                            if (el2.Attribute("name").Value == languageCode)
                                            {
                                                e.Text = el2.Value;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (c.Name.Contains("panel")) 
                            {
                                foreach (Control p in c.Controls)
                                {
                                    if (p.Name == el.Name)
                                    {
                                        if (el2.Attribute("name").Value == languageCode)
                                        {
                                            p.Text = el2.Value;
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (c.Name == el.Name)
                                {
                                    if (el2.Attribute("name").Value == languageCode)
                                    {
                                        c.Text = el2.Value;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static KeyValuePair<string, string> ResetLanguage(XDocument alpPackSourceXdocument)
        {
            var tmpKey = (Properties.Settings.Default.Language != "") ?
                alpPackSourceXdocument.Root.Elements("AvailableLanguages").Elements("language").Where(a => a.Value == Properties.Settings.Default.Language).Attributes("name").FirstOrDefault().Value :
                "En (Default)";
            var tmpValue = (Properties.Settings.Default.Language != "") ? Properties.Settings.Default.Language : "English (Default)";

            return new KeyValuePair<string, string>(tmpKey, tmpValue);
        }
        #endregion

        #region Methods: ErrorMessageReplacer
        public static string ErrorMessageReplacer(string languageCode, string originalError)
        {
            string newErrorMessage = "";

            if (errors != null)
            {
                foreach (var elError in errors.Root.Elements("error"))
                {
                    foreach (var elLang in elError.Elements("language"))
                    {
                        if (elLang.Attribute("type").Value.Contains("origin") && elLang.Value.Equals(originalError))
                        {
                            newErrorMessage = ((from el in elError.Elements() where ((string)el.Attribute("type").Value == "translate" && (string)el.Attribute("name").Value == languageCode) select el).Count() > 0) ? 
                                (from el in elError.Elements() where ((string)el.Attribute("type").Value == "translate" && (string)el.Attribute("name").Value == languageCode) select el).FirstOrDefault().Value : 
                                (from el in elError.Elements() where ((string)el.Attribute("type").Value == "translate" && (string)el.Attribute("name").Value == "En") select el).FirstOrDefault().Value;
                            
                            return newErrorMessage;
                        }
                    }
                }
            }

            if (String.IsNullOrEmpty(newErrorMessage)) newErrorMessage = originalError;

            return newErrorMessage;
        }
        #endregion

        #region Methods: Load Alp Packages
        public XDocument LoadAlp(string alpDirPath = "")
        {
            if (System.IO.File.Exists(alpDirPath))
            {
                return XDocument.Load(alpDirPath);
            }
            else 
            {
                return null;
            }
        }
        #endregion
    }
}
