namespace LMS.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courseadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        Tags = c.String(nullable: false, maxLength: 100),
                        TotalStudentsEnrolled = c.Int(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        TotalLecturesCount = c.Int(nullable: false),
                        SubTitle = c.String(nullable: false, maxLength: 100),
                        CourseSummary = c.String(maxLength: 150),
                        CourseShortDescription = c.String(maxLength: 250),
                        Language = c.String(maxLength: 50),
                        Achieve = c.String(maxLength: 50),
                        Requirements = c.String(maxLength: 50),
                        FullDescription = c.String(maxLength: 500),
                        TeacherId = c.String(maxLength: 128),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.Title)
                .Index(t => t.Price)
                .Index(t => t.Tags)
                .Index(t => t.TeacherId)
                .Index(t => t.Created)
                .Index(t => t.CreatedBy)
                .Index(t => t.Modified)
                .Index(t => t.ModifiedBy);
            
            AddColumn("dbo.Teachers", "Designation", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Teachers", "Details", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Teachers", "StudentsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "CoursesCount", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "ReviewsCount", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "Designation");
            CreateIndex("dbo.Teachers", "Details");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Teachers", new[] { "Details" });
            DropIndex("dbo.Teachers", new[] { "Designation" });
            DropIndex("dbo.Courses", new[] { "ModifiedBy" });
            DropIndex("dbo.Courses", new[] { "Modified" });
            DropIndex("dbo.Courses", new[] { "CreatedBy" });
            DropIndex("dbo.Courses", new[] { "Created" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Courses", new[] { "Tags" });
            DropIndex("dbo.Courses", new[] { "Price" });
            DropIndex("dbo.Courses", new[] { "Title" });
            DropColumn("dbo.Teachers", "ReviewsCount");
            DropColumn("dbo.Teachers", "CoursesCount");
            DropColumn("dbo.Teachers", "StudentsCount");
            DropColumn("dbo.Teachers", "Details");
            DropColumn("dbo.Teachers", "Designation");
            DropTable("dbo.Courses");
        }
    }
}
