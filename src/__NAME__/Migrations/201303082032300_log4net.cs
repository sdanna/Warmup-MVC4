namespace __NAME__.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class log4net : DbMigration
    {
        public override void Up()
        {
            var log4netSql = @"
CREATE TABLE [dbo].[Log] (
    [Id] [int] IDENTITY (1, 1) NOT NULL,
    [Date] [datetime] NOT NULL,
    [Thread] [varchar] (255) NOT NULL,
    [Level] [varchar] (50) NOT NULL,
    [Logger] [varchar] (255) NOT NULL,
    [Message] [varchar] (MAX) NOT NULL,
    [Exception] [varchar] (MAX) NULL
);
";
            this.Sql(log4netSql);
        }

        public override void Down()
        {
            DropTable("dbo.Log");
        }
    }
}
