using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace apicore.model
{

    public class Repositorio
    {
        private string conexioncadena;

        IConfiguration configuration;
        public Repositorio(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public Repositorio() {

            conexioncadena = @"DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.60.1.122)(PORT=1530))(CONNECT_DATA=(SERVICE_NAME=BANK10)));USER ID=bkwfabrica;Password=BKF@IDS10;";


        }
        //public IDbConnection connection
        //{
        //    get
        //    {

        //        var connectionString = configuration.GetSection("ConnectionStrings").GetSection("devconection").Value;
        //       return new OracleConnection(connectionString);

        //    }

        //}

        public IDbConnection connection
        {
            get
            {

                return new OracleConnection(conexioncadena);

            }

        }
        //public IDbConnection GetConnection()
        //{
        //    var connectionString = configuration.GetSection("ConnectionStrings").GetSection("EmployeeConnection").Value;
        //    var conn = new OracleConnection(connectionString);
        //    return conn;
        //}


        public COLTRANSAC getporid(string id) {


            
            using (IDbConnection dbConnection = connection) {
                
                
                //string qury = @"SELECT A.CIFCODCLIENTE, A.CIFNOMBRECLIE, A.CIFINTERNET, A.CIFFECNACIMIE ,A.CIFCELTELEFONO, A.CIFFIJTELEFONO, A.cifdocident06 FROM  SOFTWORKSR2.CIFGENERALES A  WHERE  A.CIFCODCLIENTE = "+id+ "  AND A.CIFSTATUS = 'A'  ";
                //string qury2 = @"SELECT A.CIFCODCLIENTE, A.CIFNOMBRECLIE, A.CIFINTERNET, A.CIFFECNACIMIE ,A.CIFCELTELEFONO, A.CIFFIJTELEFONO, A.cifdocident06 FROM  SOFTWORKSR2.CIFGENERALES A  WHERE  A.cifdocident06 = "+id+" AND A.CIFSTATUS = 'A'  ";
                //string qury3 = @"SELECT B.COLDIASMORAK FROM SOFTWORKSR2.coldocumento B WHERE B.COLCODCLIENTE = " + id + " AND B.coldiasmorak > 1  ";
                //string qury4 = @"SELECT B.COLDIASMORAK FROM SOFTWORKSR2.coldocumento B inner join SOFTWORKSR2.CIFGENERALES A on a.CIFCODCLIENTE = B.COLCODCLIENTE WHERE a.cifdocident06  = '" + id + "'  AND B.coldiasmorak > 1  ";
                string qury5 = @"SELECT DISTINCT a.COLNUMDOCUMEN, a.COLNUMTRANSAC, a.COLNUMBOLETA, a.COLVALINGRE01 FROM SOFTWORKSR2.coltransac a WHERE a.COLNUMBOLETA = '" + id + "'";


                dbConnection.Open();

                if (id.Length == 13) {
                    var datos = dbConnection.Query<COLTRANSAC>(qury5, new { Id = id }).FirstOrDefault();
                    //var datos2 = dbConnection.Query<CIFGENERALES>(qury4, new { Id = id }).FirstOrDefault();
                    if (datos != null )
                    {
                        return datos;

                    }

                    else {
                        return null;

                    }

                }
                //if (id.Length > 0 || id.Length <8) {
                //    var datos = dbConnection.Query<CIFGENERALES>(qury, new { Id = id }).FirstOrDefault();
                //    var datos3 = dbConnection.Query<CIFGENERALES>(qury3, new { Id = id }).FirstOrDefault();
                //    if (datos != null && datos3 == null)
                //    {
                //        return datos;

                //    }

                //    else
                //    {
                //        return null;

                //    }

                //}

                return null;
            }
        
        
        
        }



    }
}
