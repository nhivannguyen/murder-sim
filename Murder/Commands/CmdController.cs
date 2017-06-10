using System.Collections.Generic;
using MurderSim.Objects;

namespace MurderSim.Commands
{
	public class CmdController
	{
		private readonly List<Cmd> _cmdList;
		private readonly string[] _splitIds;

		public CmdController(string userinput)
		{
			_cmdList = new List<Cmd>();
			_cmdList.Add(new LookCmd());
			_cmdList.Add(new MoveCmd());
			_cmdList.Add(new TalkCmd());

			_splitIds = userinput.Split();
		}

		public Cmd Command
		{
			get => default(Cmd);
			set { }
		}

		public Cmd FindCmd()
		{
			foreach (Cmd cmd in _cmdList)
				if (cmd.AreYou(_splitIds[0]))
					return cmd;
			return null;
		}

		public string ExeCmd(Player chr)
		{
			Cmd cmd = FindCmd();
			if (cmd == null)
				return "I don't understand this command.";
			return cmd.Execute(chr, _splitIds);
		}
	}
}