using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    //customer
    public partial class customer
    {

        private readonly Maticsoft.DAL.customer dal = new Maticsoft.DAL.customer();
        public customer()
        { }

        #region  Method
       

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.customer model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.customer model)
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
        public Maticsoft.Model.customer GetModel(int id)
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
        public List<Maticsoft.Model.customer> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.customer> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.customer> modelList = new List<Maticsoft.Model.customer>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.customer model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Maticsoft.Model.customer();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.source = dt.Rows[n]["source"].ToString();
                    model.customername = dt.Rows[n]["customername"].ToString();
                    model.tel = dt.Rows[n]["tel"].ToString();
                    model.intention = dt.Rows[n]["intention"].ToString();
                    model.agent = dt.Rows[n]["agent"].ToString();
                    model.agenttel = dt.Rows[n]["agenttel"].ToString();
                    model.zygw = dt.Rows[n]["zygw"].ToString();
                    model.flag = dt.Rows[n]["flag"].ToString();
                    if (dt.Rows[n]["createdate"].ToString() != "")
                    {
                        model.createdate = DateTime.Parse(dt.Rows[n]["createdate"].ToString());
                    }
                    model.level = dt.Rows[n]["level"].ToString();


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