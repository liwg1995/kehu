using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Maticsoft.Model
{
    //customer
    public class customer
    {

        /// <summary>
        /// id
        /// </summary>		
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// source
        /// </summary>		
        private string _source;
        public string source
        {
            get { return _source; }
            set { _source = value; }
        }
        /// <summary>
        /// customername
        /// </summary>		
        private string _customername;
        public string customername
        {
            get { return _customername; }
            set { _customername = value; }
        }
        /// <summary>
        /// tel
        /// </summary>		
        private string _tel;
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        /// <summary>
        /// intention
        /// </summary>		
        private string _intention;
        public string intention
        {
            get { return _intention; }
            set { _intention = value; }
        }
        /// <summary>
        /// agent
        /// </summary>		
        private string _agent;
        public string agent
        {
            get { return _agent; }
            set { _agent = value; }
        }
        /// <summary>
        /// agenttel
        /// </summary>		
        private string _agenttel;
        public string agenttel
        {
            get { return _agenttel; }
            set { _agenttel = value; }
        }
        /// <summary>
        /// zygw
        /// </summary>		
        private string _zygw;
        public string zygw
        {
            get { return _zygw; }
            set { _zygw = value; }
        }
        /// <summary>
        /// flag
        /// </summary>		
        private string _flag;
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        /// <summary>
        /// createdate
        /// </summary>		
        private DateTime _createdate;
        public DateTime createdate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// level
        /// </summary>		
        private string _level;
        public string level
        {
            get { return _level; }
            set { _level = value; }
        }

    }
}

