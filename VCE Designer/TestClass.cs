/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "question")]
	public class Question
	{
		[XmlElement(ElementName = "difficulty")]
		public string Difficulty { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
	}

	[XmlRoot(ElementName = "answer")]
	public class Answer
	{
		[XmlElement(ElementName = "enabled")]
		public string Enabled { get; set; }
		[XmlElement(ElementName = "isright")]
		public string Isright { get; set; }
		[XmlElement(ElementName = "position")]
		public string Position { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
	}

	[XmlRoot(ElementName = "body")]
	public class Body
	{
		[XmlElement(ElementName = "question")]
		public Question Question { get; set; }
		[XmlElement(ElementName = "answer")]
		public Answer Answer { get; set; }
	}

}
