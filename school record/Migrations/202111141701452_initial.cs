namespace school_record.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.stumodels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Rollno = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        MobileNo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.stumodels");
        }
    }
}
