using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioData.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _conetionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _conetionString = _configuration["connectionStrings:DapperContext"];
        }
        public IDbConnection createConnection() => new SqlConnection(_conetionString);
    }

}
