﻿using CyberCAT.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Forms.Classes
{
    class NodeEntryTreeNode : TreeNode
    {
        public NodeEntry Node;
        public NodeEntryTreeNode(NodeEntry sourceNode)
        {
            // TODO: Add abolity for each node to provide additional text for the name
            Text = $"[{sourceNode.Id}] {sourceNode.Name}";
            Node = sourceNode;
        }
        public static List<NodeEntryTreeNode> FromList(List<NodeEntry> nodes)
        {
            var result = new List<NodeEntryTreeNode>();
            foreach(var node in nodes)
            {
                result.Add(new NodeEntryTreeNode(node));
            }
            return result;
        }
    }
}
