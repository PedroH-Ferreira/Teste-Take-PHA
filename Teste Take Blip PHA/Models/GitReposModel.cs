using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Teste_Take_Blip_PHA.Models
{
    public class GitReposModel
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("node_id")]
        public string Node_Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("full_name")]
        public string Full_Name { get; set; }
        [JsonProperty("private")]
        public bool? Private { get; set; }
        [JsonProperty("owner")]
        public Owner Owner { get; set; }
        [JsonProperty("html_url")]
        public string Html_Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("fork")]
        public bool? Fork { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("forks_url")]
        public string Forks_Url { get; set; }
        [JsonProperty("keys_url")]
        public string Keys_Url { get; set; }
        [JsonProperty("collaborators_url")]
        public string Collaborators_Url { get; set; }
        [JsonProperty("teams_url")]
        public string Teams_Url { get; set; }
        [JsonProperty("hooks_url")]
        public string Hooks_Url { get; set; }
        [JsonProperty("issue_events_url")]
        public string Issue_Events_Url { get; set; }
        [JsonProperty("events_url")]
        public string Events_Url { get; set; }
        [JsonProperty("assignees_url")]
        public string Assignees_Url { get; set; }
        [JsonProperty("branches_url")]
        public string Branches_Url { get; set; }
        [JsonProperty("tags_url")]
        public string Tags_Url { get; set; }
        [JsonProperty("blobs_url")]
        public string Blobs_Url { get; set; }
        [JsonProperty("git_tags_url")]
        public string Git_Tags_Url { get; set; }
        [JsonProperty("git_refs_url")]
        public string Git_Refs_Url { get; set; }
        [JsonProperty("trees_url")]
        public string Trees_Url { get; set; }
        [JsonProperty("statuses_url")]
        public string Statuses_Url { get; set; }
        [JsonProperty("languages_url")]
        public string Languages_Url { get; set; }
        [JsonProperty("stargazers_url")]
        public string Stargazers_Url { get; set; }
        [JsonProperty("contributors_url")]
        public string Contributors_Url { get; set; }
        [JsonProperty("subscribers_url")]
        public string Subscribers_Url { get; set; }
        [JsonProperty("subscription_url")]
        public string Subscriotion_Url { get; set; }
        [JsonProperty("commits_url")]
        public string Commits_Url { get; set; }
        [JsonProperty("git_commits_url")]
        public string Git_Commits_Url { get; set; }
        [JsonProperty("comments_url")]
        public string Comments_Url { get; set; }
        [JsonProperty("issue_comment_url")]
        public string Issue_Comment_Url { get; set; }
        [JsonProperty("contents_url")]
        public string Contents_Url { get; set; }
        [JsonProperty("compare_url")]
        public string Compare_Url { get; set; }
        [JsonProperty("merges_url")]
        public string Merges_Url { get; set; }
        [JsonProperty("archive_url")]
        public string Archive_Url { get; set; }
        [JsonProperty("downloads_url")]
        public string Downloads_Url { get; set; }
        [JsonProperty("issues_url")]
        public string Issues_Url { get; set; }
        [JsonProperty("pulls_url")]
        public string Pulls_Url { get; set; }
        [JsonProperty("milestones_url")]
        public string Milestones_Url { get; set; }
        [JsonProperty("notifications_url")]
        public string Notifications_Url { get; set; }
        [JsonProperty("labels_url")]
        public string Labels_Url { get; set; }
        [JsonProperty("releases_url")]
        public string Releases_Url { get; set; }
        [JsonProperty("deployments_url")]
        public string Deployments_Url { get; set; }
        [JsonProperty("created_at")]
        public DateTime? Created_At { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? Updated_At { get; set; }
        [JsonProperty("pushed_at")]
        public DateTime? Pushed_At { get; set; }
        [JsonProperty("git_url")]
        public string Git_Url { get; set; }
        [JsonProperty("ssh_url")]
        public string Ssh_Url { get; set; }
        [JsonProperty("clone_url")]
        public string Clone_Url { get; set; }
        [JsonProperty("svn_url")]
        public string Svn_Url { get; set; }
        [JsonProperty("homepage")]
        public string Homepage { get; set; }
        [JsonProperty("size")]
        public int? Size { get; set; }
        [JsonProperty("stargazers_count")]
        public int? Stargazers_Count { get; set; }
        [JsonProperty("watchers_count")]
        public int? Watchers_Count { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("has_issues")]
        public bool? Has_Issues { get; set; }
        [JsonProperty("has_projects")]
        public bool? Has_Projects { get; set; }
        [JsonProperty("has_downloads")]
        public bool? Has_Downloads { get; set; }
        [JsonProperty("has_wiki")]
        public bool? Has_Wiki { get; set; }
        [JsonProperty("has_pages")]
        public bool? Has_Pages { get; set; }
        [JsonProperty("forks_count")]
        public int? Forks_Count { get; set; }
        [JsonProperty("mirror_url")]
        public string Mirror_Url { get; set; }
        [JsonProperty("archived")]
        public bool? Archived { get; set; }
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
        [JsonProperty("open_issues_count")]
        public int? Open_Issues_Count { get; set; }
        [JsonProperty("license")]
        public License License { get; set; }
        [JsonProperty("allow_forking")]
        public bool? Allow_Forking { get; set; }
        [JsonProperty("is_template")]
        public bool? Is_Template { get; set; }
        [JsonProperty("topics")]
        public IEnumerable<string> Topics { get; set; }
        [JsonProperty("visibility")]
        public string Visibility { get; set; }
        [JsonProperty("forks")]
        public int? Forks { get; set; }
        [JsonProperty("open_issues")]
        public int? Open_Issues { get; set; }
        [JsonProperty("watchers")]
        public int? Watchers { get; set; }
        [JsonProperty("default_branch")]
        public string Default_Branch { get; set; }
        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }
    }
}
