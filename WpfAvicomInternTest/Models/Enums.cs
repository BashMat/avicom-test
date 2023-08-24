using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAvicomInternTest.Models
{
	/// <summary>
	/// Тип клиента – физическое или юридическое лицо.
	/// </summary>
	enum ClientType
	{
		Natural,
		Legal
	}

	/// <summary>
	/// Есть статус клиента (ClientStatus), принимает значения: Ключевой клиент, Обычный клиент.
	/// </summary>
	enum ClientStatus
	{
		KeyClient,
		OrdinaryClient
	}

	/// <summary>
	/// Тип (подписка или постоянная лицензия)
	/// </summary>
	enum ProductType
	{
		Subscription,
		ConstantLicense
	}

	/// <summary>
	/// Срок подписки (месяц / квартал / год)
	/// </summary>
	enum ProductDuration
	{
		Day,
		Quarter,
		Year
	}
}
