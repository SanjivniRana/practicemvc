namespace practicemvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _this : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        abc = c.String(),
                        xyz = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MemberTypes");
        }
    }
}
