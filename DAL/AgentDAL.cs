using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //Agent
    public partial class Agent
    {

        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Agent");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Agent(");
            strSql.Append("category,agentname,tel,addr,point,cuscount,flag,createdate");
            strSql.Append(") values (");
            strSql.Append("@category,@agentname,@tel,@addr,@point,@cuscount,@flag,@createdate");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@category", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agentname", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@addr", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@point", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@cuscount", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.category;
            parameters[1].Value = model.agentname;
            parameters[2].Value = model.tel;
            parameters[3].Value = model.addr;
            parameters[4].Value = model.point;
            parameters[5].Value = model.cuscount;
            parameters[6].Value = model.flag;
            parameters[7].Value = model.createdate;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Agent set ");

            strSql.Append(" category = @category , ");
            strSql.Append(" agentname = @agentname , ");
            strSql.Append(" tel = @tel , ");
            strSql.Append(" addr = @addr , ");
            strSql.Append(" point = @point , ");
            strSql.Append(" cuscount = @cuscount , ");
            strSql.Append(" flag = @flag , ");
            strSql.Append(" createdate = @createdate  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@category", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agentname", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@addr", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@point", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@cuscount", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.id;
            parameters[1].Value = model.category;
            parameters[2].Value = model.agentname;
            parameters[3].Value = model.tel;
            parameters[4].Value = model.addr;
            parameters[5].Value = model.point;
            parameters[6].Value = model.cuscount;
            parameters[7].Value = model.flag;
            parameters[8].Value = model.createdate;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Agent ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Agent ");
            strSql.Append(" where ID in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.Agent GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id, category, agentname, tel, addr, point, cuscount, flag, createdate  ");
            strSql.Append("  from Agent ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


            Maticsoft.Model.Agent model = new Maticsoft.Model.Agent();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.category = ds.Tables[0].Rows[0]["category"].ToString();
                model.agentname = ds.Tables[0].Rows[0]["agentname"].ToString();
                model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                model.addr = ds.Tables[0].Rows[0]["addr"].ToString();
                model.point = ds.Tables[0].Rows[0]["point"].ToString();
                model.cuscount = ds.Tables[0].Rows[0]["cuscount"].ToString();
                model.flag = ds.Tables[0].Rows[0]["flag"].ToString();
                if (ds.Tables[0].Rows[0]["createdate"].ToString() != "")
                {
                    model.createdate = DateTime.Parse(ds.Tables[0].Rows[0]["createdate"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Agent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM Agent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

