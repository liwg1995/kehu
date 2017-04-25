using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Maticsoft.Model
{
    //Agent
    public class Agent
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
        /// category
        /// </summary>		
        private string _category;
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
        /// <summary>
        /// agentname
        /// </summary>		
        private string _agentname;
        public string agentname
        {
            get { return _agentname; }
            set { _agentname = value; }
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
        /// addr
        /// </summary>		
        private string _addr;
        public string addr
        {
            get { return _addr; }
            set { _addr = value; }
        }
        /// <summary>
        /// point
        /// </summary>		
        private string _point;
        public string point
        {
            get { return _point; }
            set { _point = value; }
        }
        /// <summary>
        /// cuscount
        /// </summary>		
        private string _cuscount;
        public string cuscount
        {
            get { return _cuscount; }
            set { _cuscount = value; }
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

    }
}

