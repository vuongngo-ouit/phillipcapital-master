using Refit;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace PhillipCapital.Utilities
{
    public abstract class BaseViewModel: INotifyPropertyChanged
    {
		private readonly ConcurrentDictionary<Type, object> RestApiDictionary;
		private string ApiEndpoint = "";
		private const string FunctionKey = "nRhVhsKwSEntvqHHlmN09XjRkmyIhLZBXaaiOZ/HAh3sPdm9zamKkg==";

		public BaseViewModel()
		{
			RestApiDictionary = new ConcurrentDictionary<Type, object>();
		}

		private HttpClient _httpClient;
		public HttpClient HttpClient
		{
			get
			{
				if (_httpClient != null)
					return _httpClient;

				_httpClient = new HttpClient(new HttpClientHandlerExt(FunctionKey)) { BaseAddress = new Uri(ApiEndpoint) };

				return _httpClient;
			}
		}

		public T RestApi<T>()
		{
			var type = typeof(T);
			if (RestApiDictionary.ContainsKey(type))
			{
				return (T)RestApiDictionary[type];
			}

			var restApi = RestService.For<T>(HttpClient);

			RestApiDictionary.GetOrAdd(type, restApi);

			return restApi;
		}

		protected bool _isBusy;
		public virtual bool IsBusy
		{
			get => _isBusy;
			set => SetProperty(ref _isBusy, value);
		}

		private string _title = string.Empty;
		public string Title
		{
			get => _title;
			set => SetProperty(ref _title, value);
		}

		/// <summary>
		/// Occurs when the property is changed.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		#region Methods
		protected void SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
		{
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
				return;

			backingStore = value;
			onChanged?.Invoke();
			NotifyPropertyChanged(propertyName);
		}

		/// <summary>
		/// The PropertyChanged event occurs when changing the value of property.
		/// </summary>
		/// <param name="propertyName">The PropertyName</param>
		protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
