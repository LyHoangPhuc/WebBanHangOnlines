namespace WebBanHangOnlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update12062 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Link", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 150));
            DropColumn("dbo.tb_Category", "Link");
        }
    }
}
