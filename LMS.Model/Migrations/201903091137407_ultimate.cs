namespace LMS.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultimate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Teachers", new[] { "Designation" });
            DropIndex("dbo.Teachers", new[] { "Details" });
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Serial = c.Int(nullable: false),
                        CourseId = c.String(maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(nullable: false, maxLength: 500),
                        Url = c.String(nullable: false, maxLength: 250),
                        TotalSeconds = c.Int(nullable: false),
                        Tags = c.String(nullable: false, maxLength: 250),
                        Category = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.Title)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modified)
                .Index(t => t.ModifiedBy);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StudentId = c.String(maxLength: 128),
                        CourseId = c.String(maxLength: 128),
                        IsPaid = c.Boolean(nullable: false),
                        PaidTotal = c.Double(nullable: false),
                        Due = c.Double(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        CompletedContent = c.Int(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modified)
                .Index(t => t.ModifiedBy);
            
            CreateTable(
                "dbo.StudentContents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StudentId = c.String(maxLength: 128),
                        ContentId = c.String(maxLength: 128),
                        WatchedSeconds = c.Int(),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contents", t => t.ContentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.ContentId)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modified)
                .Index(t => t.ModifiedBy);
            
            AddColumn("dbo.Teachers", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Teachers", "Phone", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Teachers", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teachers", "Designation", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teachers", "Details", c => c.String(maxLength: 500));
            CreateIndex("dbo.Teachers", "Email");
            CreateIndex("dbo.Teachers", "Phone");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentContents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentContents", "ContentId", "dbo.Contents");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Contents", "CourseId", "dbo.Courses");
            DropIndex("dbo.StudentContents", new[] { "ModifiedBy" });
            DropIndex("dbo.StudentContents", new[] { "Modified" });
            DropIndex("dbo.StudentContents", new[] { "CreatedBy" });
            DropIndex("dbo.StudentContents", new[] { "Created" });
            DropIndex("dbo.StudentContents", new[] { "ContentId" });
            DropIndex("dbo.StudentContents", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "ModifiedBy" });
            DropIndex("dbo.Enrollments", new[] { "Modified" });
            DropIndex("dbo.Enrollments", new[] { "CreatedBy" });
            DropIndex("dbo.Enrollments", new[] { "Created" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Teachers", new[] { "Phone" });
            DropIndex("dbo.Teachers", new[] { "Email" });
            DropIndex("dbo.Contents", new[] { "ModifiedBy" });
            DropIndex("dbo.Contents", new[] { "Modified" });
            DropIndex("dbo.Contents", new[] { "CreatedBy" });
            DropIndex("dbo.Contents", new[] { "Created" });
            DropIndex("dbo.Contents", new[] { "Title" });
            DropIndex("dbo.Contents", new[] { "CourseId" });
            AlterColumn("dbo.Teachers", "Details", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "Designation", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Teachers", "Address");
            DropColumn("dbo.Teachers", "Phone");
            DropColumn("dbo.Teachers", "Email");
            DropTable("dbo.StudentContents");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Contents");
            CreateIndex("dbo.Teachers", "Details");
            CreateIndex("dbo.Teachers", "Designation");
        }
    }
}
