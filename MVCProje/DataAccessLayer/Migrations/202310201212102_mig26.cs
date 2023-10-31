namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig26 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminMail", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminMail");
        }
    }
}
