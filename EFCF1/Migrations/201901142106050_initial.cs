namespace EFCF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DepartmanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departmen", t => t.DepartmanID, cascadeDelete: true)
                .Index(t => t.DepartmanID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "DepartmanID", "dbo.Departmen");
            DropIndex("dbo.Personels", new[] { "DepartmanID" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departmen");
        }
    }
}
