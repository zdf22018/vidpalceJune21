namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            Sql("insert into memberships" +
                "(Id,signupfee,durationinmonths,discountrate)"+"values(1,1,1,1)");

            Sql("insert into memberships" +
               "(Id,signupfee,durationinmonths,discountrate)" + "values(4,100,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
