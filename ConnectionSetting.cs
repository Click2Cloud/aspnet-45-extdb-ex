#region Copyright ©2016, Click2Cloud Inc. - All Rights Reserved
/* ------------------------------------------------------------------- *
*                            Click2Cloud Inc.                          *
*                  Copyright ©2016 - All Rights reserved               *
*                                                                      *
* Apache 2.0 License                                                   *
* You may obtain a copy of the License at                              * 
* http://www.apache.org/licenses/LICENSE-2.0                           *
* Unless required by applicable law or agreed to in writing,           *
* software distributed under the License is distributed on an "AS IS"  *
* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express  *
* or implied. See the License for the specific language governing      *
* permissions and limitations under the License.                       *
*                                                                      *
* -------------------------------------------------------------------  */
#endregion Copyright ©2016, Click2Cloud Inc. - All Rights Reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnet_mssql_sample
{
    public static class ConnectionSetting
    {
        internal static string CONNECTION_STRING
        {
            get
            {
                if (!(string.IsNullOrEmpty(MSSQL_SERVICE_HOST) || string.IsNullOrEmpty(MSSQL_SERVICE_PORT)
                || string.IsNullOrEmpty(MSSQL_DATABASE) || string.IsNullOrEmpty(MSSQL_USER) || string.IsNullOrEmpty(MSSQL_PASSWORD)))
                {
                    string _connectionString = string.Format("Data Source={0},{1};Initial Catalog={2};Persist Security Info=True;User ID={3};Password={4};", MSSQL_SERVICE_HOST,
                        MSSQL_SERVICE_PORT, MSSQL_DATABASE, MSSQL_USER, MSSQL_PASSWORD);

                    return _connectionString;
                }
                else { throw new Exception("Environment variables are not configured"); }
            }
        }

        #region Get Environment Variables

        private static string MSSQL_SERVICE_HOST
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_SERVER")))
                {
                    return Environment.GetEnvironmentVariable("DATABASE_SERVER");
                }

                return string.Empty;
            }
        }

        private static string MSSQL_SERVICE_PORT
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_PORT")))
                {
                    return Environment.GetEnvironmentVariable("DATABASE_PORT");
                }

                return string.Empty;
            }
        }

        private static string MSSQL_DATABASE
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_NAME")))
                {
                    return Environment.GetEnvironmentVariable("DATABASE_NAME");
                }

                return string.Empty;
            }
        }

        private static string MSSQL_USER
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_USER")))
                {
                    return Environment.GetEnvironmentVariable("DATABASE_USER");
                }

                return string.Empty;
            }
        }

        private static string MSSQL_PASSWORD
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_PASSWORD")))
                {
                    return Environment.GetEnvironmentVariable("DATABASE_PASSWORD");
                }

                return string.Empty;
            }
        }

        #endregion

    }
}
