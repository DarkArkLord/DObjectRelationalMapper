﻿using Microsoft.Data.SqlClient;

namespace UsefulItems.CSharp.SqlUtils.DarkORM.Commands.HandleStrategy
{
    public class NonQueryHandleStrategy : IHandleStrategy
    {
        public int Result { get; set; }

        public void Execute(SqlCommand command)
        {
            Result = command.ExecuteNonQuery();
        }
    }
}
