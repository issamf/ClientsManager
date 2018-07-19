using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClientsManager.Classes
{
    public class Customer
    {
        protected string name = "";
        protected string phone1 = "";
        protected string phone2 = "";
        protected string id = "";
        protected string caseid = "";
        protected string businessName = "";
        protected string email = "";

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Phone1
        {
            get
            {
                return phone1;
            }
            set
            {
                phone1 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string CaseID
        {
            get
            {
                return caseid;
            }
            set
            {
                caseid = value;
            }
        }

        public string BusinessName
        {
            get
            {
                return businessName;
            }
            set
            {
                businessName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public Customer(string name, string id, string phone1, string phone2, string caseId,string business, string email)
        {
            this.name = name;
            this.id = id;
            this.phone1 = phone1;
            this.phone2 = phone2;
            this.caseid = caseId;
            this.businessName = business;
            this.email = email;
        }

        public XElement ToXML()
        {
            XElement elm = new XElement("Customer",
                new XElement("Name", Name),
                new XElement("ID", ID),
                new XElement("Phone1",Phone1),
                new XElement("Phone2",Phone2),
                new XElement("CaseID",CaseID),
                new XElement("BusinessName",BusinessName),
                new XElement("Email",Email));
            return elm;
        }

        public static Customer FromXML(XElement element)
        {
            return new Customer(element.Element("Name").Value, element.Element("ID").Value,
                element.Element("Phone1").Value, element.Element("Phone2").Value,
                element.Element("CaseID").Value, element.Element("BusinessName").Value,
                element.Element("Email").Value);
        }
    }
}
