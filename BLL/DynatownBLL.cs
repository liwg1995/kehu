using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    //Dynatown
    public partial class Dynatown
    {

        private readonly Maticsoft.DAL.Dynatown dal = new Maticsoft.DAL.Dynatown();
        public Dynatown()
        { }

        #region  Method
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.Dynatown model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.Dynatown model)
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
        public Maticsoft.Model.Dynatown GetModel(int id)
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
        public List<Maticsoft.Model.Dynatown> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.Dynatown> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.Dynatown> modelList = new List<Maticsoft.Model.Dynatown>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.Dynatown model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Maticsoft.Model.Dynatown();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.accnumber = dt.Rows[n]["accnumber"].ToString();
                    model.Dyname = dt.Rows[n]["Dyname"].ToString();
                    model.tel = dt.Rows[n]["tel"].ToString();
                    model.company = dt.Rows[n]["company"].ToString();
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