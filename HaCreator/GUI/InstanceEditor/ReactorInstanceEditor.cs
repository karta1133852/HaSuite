﻿/* Copyright (C) 2015 haha01haha01

* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaCreator.MapEditor;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class ReactorInstanceEditor : Form
    {
        public ReactorInstance item;

        public ReactorInstanceEditor(ReactorInstance item)
        {
            InitializeComponent();
            this.item = item;
            xInput.Value = item.X;
            yInput.Value = item.Y;
            pathLabel.Text = HaCreatorStateManager.CreateItemDescription(item, "\r\n");
            if (item.Name == null) useName.Checked = false;
            else nameBox.Text = item.Name;
            timeBox.Value = item.ReactorTime;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<UndoRedoAction> actions = new List<UndoRedoAction>();
            if (xInput.Value != item.X || yInput.Value != item.Y)
            {
                actions.Add(UndoRedoManager.ItemMoved(item, new Microsoft.Xna.Framework.Point(item.X, item.Y), new Microsoft.Xna.Framework.Point((int)xInput.Value, (int)yInput.Value)));
                item.Move((int)xInput.Value, (int)yInput.Value);
            }
            if (actions.Count > 0)
                item.Board.UndoRedoMan.AddUndoBatch(actions);
            item.Name = useName.Checked ? nameBox.Text : null;
            item.ReactorTime = (int)timeBox.Value;
            Close();
        }

        private void useName_CheckedChanged(object sender, EventArgs e)
        {
            nameBox.Enabled = useName.Checked;
        }
    }
}