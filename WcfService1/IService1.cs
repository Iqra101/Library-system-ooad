﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddBookToLib(string name, string Location, string Quantity);
        [OperationContract]
        bool DeleteBookFromLib(string name, string Location);

        [OperationContract]
        bool forgetpassword(string username, string question, string answer);
        [OperationContract]
        void registration(string username, string password, string q, string a);
        [OperationContract]
        bool isvaliduser(string username, string password);
        [OperationContract]
        bool isvalidAdmin(string username, string password);
        [OperationContract]
        void resetpassword(string username, string password);
 
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
