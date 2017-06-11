using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MurderSim.Objects;

namespace MurderSimForm
{
    public partial class MurderWinForm : Form
    {
	    private God _god;
	    private Player _player;

        public MurderWinForm()
        {
            InitializeComponent();
			_god = new God();
	        _player = _god.CreatesPlayer();
	        dispBox.Text = $"Welcome to this world, {_player.Name}.\r" +
	                       $"Just confirming, you are {_player.FullDescription}\r";
	        nameData.Text = _player.Name;
	        locData.Text = $"{_player.Location.Name}, {_player.Location.Description}";
	        invenData.Text = _player.Inventory.ItemList;
        }

		private void enterButt_Click(object sender, EventArgs e)
		{
			dispBox.Text += $"{inputBox.Text} \r-> {_god.FulfillRequestTo(inputBox.Text, _player)}";
			inputBox.Text = "";
			locData.Text = $"{_player.Location.Name}, {_player.Location.Description}";
			invenData.Text = _player.Inventory.ItemList;
		}
	}
}
