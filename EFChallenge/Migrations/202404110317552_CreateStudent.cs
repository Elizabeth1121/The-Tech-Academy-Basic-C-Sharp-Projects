﻿namespace EFChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fName = c.String(),
                        lName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
