using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //customer
    public partial class customer
    {

        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from customer");
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
        public int Add(Maticsoft.Model.customer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into customer(");
            strSql.Append("source,customername,tel,intention,agent,agenttel,zygw,flag,createdate,level");
            strSql.Append(") values (");
            strSql.Append("@source,@customername,@tel,@intention,@agent,@agenttel,@zygw,@flag,@createdate,@level");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@source", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@customername", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@intention", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agent", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agenttel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@zygw", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@level", SqlDbType.VarChar,10)             
              
            };

            parameters[0].Value = model.source;
            parameters[1].Value = model.customername;
            parameters[2].Value = model.tel;
            parameters[3].Value = model.intention;
            parameters[4].Value = model.agent;
            parameters[5].Value = model.agenttel;
            parameters[6].Value = model.zygw;
            parameters[7].Value = model.flag;
            parameters[8].Value = model.createdate;
            parameters[9].Value = model.level;

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
        public bool Update(Maticsoft.Model.customer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update customer set ");

            strSql.Append(" source = @source , ");
            strSql.Append(" customername = @customername , ");
            strSql.Append(" tel = @tel , ");
            strSql.Append(" intention = @intention , ");
            strSql.Append(" agent = @agent , ");
            strSql.Append(" agenttel = @agenttel , ");
            strSql.Append(" zygw = @zygw , ");
            strSql.Append(" flag = @flag , ");
            strSql.Append(" createdate = @createdate , ");
            strSql.Append(" level = @level  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@source", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@customername", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@intention", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agent", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@agenttel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@zygw", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@level", SqlDbType.VarChar,10)             
              
            };

            parameters[0].Value = model.id;
            parameters[1].Value = model.source;
            parameters[2].Value = model.customername;
            parameters[3].Value = model.tel;
            parameters[4].Value = model.intention;
            parameters[5].Value = model.agent;
            parameters[6].Value = model.agenttel;
            parameters[7].Value = model.zygw;
            parameters[8].Value = model.flag;
            parameters[9].Value = model.createdate;
            parameters[10].Value = model.level;
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
            strSql.Append("delete from customer ");
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
            strSql.Append("delete from customer ");
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
        public Maticsoft.Model.customer GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id, source, customername, tel, intention, agent, agenttel, zygw, flag, createdate, level  ");
            strSql.Append("  from customer ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


            Maticsoft.Model.customer model = new Maticsoft.Model.customer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.source = ds.Tables[0].Rows[0]["source"].ToString();
                model.customername = ds.Tables[0].Rows[0]["customername"].ToString();
                model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                model.intention = ds.Tables[0].Rows[0]["intention"].ToString();
                model.agent = ds.Tables[0].Rows[0]["agent"].ToString();
                model.agenttel = ds.Tables[0].Rows[0]["agenttel"].ToString();
                model.zygw = ds.Tables[0].Rows[0]["zygw"].ToString();
                model.flag = ds.Tables[0].Rows[0]["flag"].ToString();
                if (ds.Tables[0].Rows[0]["createdate"].ToString() != "")
                {
                    model.createdate = DateTime.Parse(ds.Tables[0].Rows[0]["createdate"].ToString());
                }
                model.level = ds.Tables[0].Rows[0]["level"].ToString();

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
            strSql.Append(" FROM customer ");
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
            strSql.Append(" FROM customer ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

