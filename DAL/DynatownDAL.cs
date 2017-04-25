using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //Dynatown
    public partial class Dynatown
    {

        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Dynatown");
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
        public int Add(Maticsoft.Model.Dynatown model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Dynatown(");
            strSql.Append("accnumber,Dyname,tel,company,flag,createdate");
            strSql.Append(") values (");
            strSql.Append("@accnumber,@Dyname,@tel,@company,@flag,@createdate");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@accnumber", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Dyname", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@company", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.accnumber;
            parameters[1].Value = model.Dyname;
            parameters[2].Value = model.tel;
            parameters[3].Value = model.company;
            parameters[4].Value = model.flag;
            parameters[5].Value = model.createdate;

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
        public bool Update(Maticsoft.Model.Dynatown model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Dynatown set ");

            strSql.Append(" accnumber = @accnumber , ");
            strSql.Append(" Dyname = @Dyname , ");
            strSql.Append(" tel = @tel , ");
            strSql.Append(" company = @company , ");
            strSql.Append(" flag = @flag , ");
            strSql.Append(" createdate = @createdate  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@accnumber", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Dyname", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@tel", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@company", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@flag", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@createdate", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.id;
            parameters[1].Value = model.accnumber;
            parameters[2].Value = model.Dyname;
            parameters[3].Value = model.tel;
            parameters[4].Value = model.company;
            parameters[5].Value = model.flag;
            parameters[6].Value = model.createdate;
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
            strSql.Append("delete from Dynatown ");
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
            strSql.Append("delete from Dynatown ");
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
        public Maticsoft.Model.Dynatown GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id, accnumber, Dyname, tel, company, flag, createdate  ");
            strSql.Append("  from Dynatown ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;


            Maticsoft.Model.Dynatown model = new Maticsoft.Model.Dynatown();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.accnumber = ds.Tables[0].Rows[0]["accnumber"].ToString();
                model.Dyname = ds.Tables[0].Rows[0]["Dyname"].ToString();
                model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                model.company = ds.Tables[0].Rows[0]["company"].ToString();
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
            strSql.Append(" FROM Dynatown ");
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
            strSql.Append(" FROM Dynatown ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

