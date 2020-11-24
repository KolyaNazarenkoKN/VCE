/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "answer")]
	public class Answer
	{
		[XmlElement(ElementName = "isright")]
		public string Isright { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
	}

	[XmlRoot(ElementName = "question")]
	public class Question
	{
		[XmlElement(ElementName = "NameQuestion")]
		public string NameQuestion { get; set; }
		[XmlElement(ElementName = "answer")]
		public List<Answer> Answer { get; set; }
	}

	[XmlRoot(ElementName = "body")]
	public class Body
	{
		[XmlElement(ElementName = "Author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "TestName")]
		public string TestName { get; set; }
		[XmlElement(ElementName = "question")]
		public List<Question> Question { get; set; }
	}

}
