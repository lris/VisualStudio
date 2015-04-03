﻿using GitHub.Models;
using Microsoft.TeamFoundation.Controls;
using System.ComponentModel.Composition;

namespace GitHub.VisualStudio.TeamExplorerConnect
{
    [TeamExplorerSection(GitHubConnectSection1Id, TeamExplorerPageIds.Connect, 10)]
    public class GitHubConnectSection1 : GitHubConnectSection
    {
        public const string GitHubConnectSection1Id = "519B47D3-F2A9-4E19-8491-8C9FA25ABE91";

        [ImportingConstructor]
        public GitHubConnectSection1(IConnectionManager manager) : base(manager, 1)
        {
        }
    }
}