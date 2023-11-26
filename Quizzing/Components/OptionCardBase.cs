using Microsoft.AspNetCore.Components;

namespace Quizzing.Components
{
	public class OptionCardBase : ComponentBase
	{
		[Parameter]	
		public string Option { get; set; } = string.Empty;

		[Parameter]
		public EventCallback<string> onOptionSelected { get; set; }

		protected async void SelectedOption()
		{
			await onOptionSelected.InvokeAsync(Option);
		}
	}
}
