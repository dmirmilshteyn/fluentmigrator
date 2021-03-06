﻿namespace FluentMigrator.Runner.Processors.DB2
{
    using FluentMigrator.Runner.Generators.DB2;
    using System.Data.Common;

    public class Db2ProcessorFactory : MigrationProcessorFactory
    {
        #region Methods

        public override IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options)
        {
            var factory = new Db2DbFactory();
            var connection = (DbConnection)factory.CreateConnection(connectionString);
            return new Db2Processor(connection, new Db2Generator(), announcer, options, factory);
        }

        #endregion Methods
    }
}