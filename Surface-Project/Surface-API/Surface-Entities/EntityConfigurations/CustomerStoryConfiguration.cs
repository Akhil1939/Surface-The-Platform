

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surface_Entities.Entities;

namespace Surface_Entities.EntityConfigurations
{
    public class CustomerStoryConfiguration : IEntityTypeConfiguration<CustomerStory>
    {
        public void Configure(EntityTypeBuilder<CustomerStory> entity)
        {
            entity
                                .HasOne(e => e.Status)
                                .WithMany()
                                .HasForeignKey(e => e.StatusId)
                                .IsRequired()
                                .OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.Project)
                .WithMany(e=>e.CustomerStories)
                .HasForeignKey(e => e.ProjectId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(e => e.CreatedByUser)
                .WithMany()
                .HasForeignKey(e => e.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.ModifiedByUser)
                .WithMany()
                .HasForeignKey(e => e.ModifiedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            entity.HasData(
                new CustomerStory[]
                {
                    new CustomerStory
                    {
                        Id = 1,
                        Name = "Surface Story 1",
                        Story = "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>",
                        Index = 1,
                        ProjectId= 1,
                        StatusId = 26,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedOn= DateTime.Now,
                    },
                    new CustomerStory
                    {
                        Id = 2,
                        Name = "Surface Story 1",
                        Story = "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>",
                        Index = 2,
                        ProjectId= 1,
                        StatusId = 26,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedOn= DateTime.Now,
                    },
                    new CustomerStory
                    {
                        Id = 3,
                        Name = "Surface Story 1",
                        Story = "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>",
                        Index = 3,
                        ProjectId= 1,
                        StatusId = 26,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedOn= DateTime.Now,
                    }
                });
        }
    }
}
