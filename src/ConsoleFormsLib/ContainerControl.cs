using System.Collections.ObjectModel;

namespace ConsoleFormsLib;

public class ContainerControl : Control
{
	private ObservableCollection<Control> _controls = new ObservableCollection<Control>(); 
	ObservableCollection<Control> Controls { get => _controls; }
	event EventHandler? ControlsChanged;
}

