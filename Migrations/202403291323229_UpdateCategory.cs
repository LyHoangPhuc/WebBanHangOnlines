namespace WebBanHangOnlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_CAtegory", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_CAtegory", "SeoDescription", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_CAtegory", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_CAtegory", "SeoKeywords", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_CAtegory", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_CAtegory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_CAtegory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_CAtegory", "Title", c => c.String());
        }
    }
}
