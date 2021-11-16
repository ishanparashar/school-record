namespace school_record.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_fathernamecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.stumodels", "Father_name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.stumodels", "Father_name");
        }
    }
}
