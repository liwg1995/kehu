using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    //Agent
    public partial class Agent
    {

        private readonly Maticsoft.DAL.Agent dal = new Maticsoft.DAL.Agent();
        public Agent()
        { }

        #region  Method
       

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.Agent model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.Agent model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            return dal.Delete(id);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.Agent GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.Agent> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.Agent> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.Agent> modelList = new List<Maticsoft.Model.Agent>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.Agent model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Maticsoft.Model.Agent();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.category = dt.Rows[n]["category"].ToString();
                    model.agentname = dt.Rows[n]["agentname"].ToString();
                    model.tel = dt.Rows[n]["tel"].ToString();
                    model.addr = dt.Rows[n]["addr"].ToString();
                    model.point = dt.Rows[n]["point"].ToString();
                    model.cuscount = dt.Rows[n]["cuscount"].ToString();
                    model.flag = dt.Rows[n]["flag"].ToString();
                    if (dt.Rows[n]["createdate"].ToString() != "")
                    {
                        model.createdate = DateTime.Parse(dt.Rows[n]["createdate"].ToString());
                    }


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

    }
}