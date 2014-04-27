
using System;

namespace GitHub.PushEvent.Example.Models
{
    public class GitHubPushEvent
    {
        public string _ref { get; set; }
        public string after { get; set; }
        public string before { get; set; }
        public bool created { get; set; }
        public bool deleted { get; set; }
        public bool forced { get; set; }
        public string compare { get; set; }
        public Commit[] commits { get; set; }
        public Head_Commit head_commit { get; set; }
        public Repository repository { get; set; }
        public Pusher pusher { get; set; }
        public Distinct_Commits[] distinct_commits { get; set; }
        public string ref_name { get; set; }

        public class Head_Commit
        {
            public string id { get; set; }
            public bool distinct { get; set; }
            public string message { get; set; }
            public DateTime timestamp { get; set; }
            public string url { get; set; }
            public Author author { get; set; }
            public Committer committer { get; set; }
            public object[] added { get; set; }
            public object[] removed { get; set; }
            public string[] modified { get; set; }
        }

        public class Author
        {
            public string name { get; set; }
            public string email { get; set; }
            public string username { get; set; }
        }

        public class Committer
        {
            public string name { get; set; }
            public string email { get; set; }
            public string username { get; set; }
        }

        public class Repository
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string description { get; set; }
            public int watchers { get; set; }
            public int stargazers { get; set; }
            public int forks { get; set; }
            public bool fork { get; set; }
            public int size { get; set; }
            public Owner owner { get; set; }
            public bool _private { get; set; }
            public int open_issues { get; set; }
            public bool has_issues { get; set; }
            public bool has_downloads { get; set; }
            public bool has_wiki { get; set; }
            public int created_at { get; set; }
            public int pushed_at { get; set; }
            public string master_branch { get; set; }
        }

        public class Owner
        {
            public string name { get; set; }
            public string email { get; set; }
        }

        public class Pusher
        {
            public string name { get; set; }
            public string email { get; set; }
        }

        public class Commit
        {
            public string id { get; set; }
            public bool distinct { get; set; }
            public string message { get; set; }
            public DateTime timestamp { get; set; }
            public string url { get; set; }
            public Author author { get; set; }
            public Committer committer { get; set; }
            public object[] added { get; set; }
            public object[] removed { get; set; }
            public string[] modified { get; set; }
        }

        public class Distinct_Commits
        {
            public string id { get; set; }
            public bool distinct { get; set; }
            public string message { get; set; }
            public DateTime timestamp { get; set; }
            public string url { get; set; }
            public Author author { get; set; }
            public Committer committer { get; set; }
            public object[] added { get; set; }
            public object[] removed { get; set; }
            public string[] modified { get; set; }
        }
    }
}