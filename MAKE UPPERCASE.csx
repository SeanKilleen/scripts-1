// This script changes all tag values to uppercase ("The Artist" -> "THE ARTIST")

string NewValue(string oldValue) => oldValue.ToUpper();

foreach (var file in files)
	foreach (var tag in file.GetAllTags())
		foreach (string tagValue in tag.Value)
			file.SetTagValue(tag.Key, tagValue, NewValue(tagValue));