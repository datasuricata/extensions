    public static class DropdownExtension
    {
        public static List<GenericDropdownDTO> ToDropdown<T>(this List<T> list, string text, string value)
        {
            List<GenericDropdownDTO> dropdown = new List<GenericDropdownDTO>();

            foreach (var item in list)
            {
                var sItem = new GenericDropdownDTO();
                sItem.Text = item.GetType().GetProperty(text).GetValue(item, null) as string;
                sItem.Value = item.GetType().GetProperty(value).GetValue(item, null) as string;

                dropdown.Add(sItem);

            }

            return dropdown;
        }
    }
    
    public class GenericDropdownDTO
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public GenericDropdownDTO()
        {
            
        }

        public GenericDropdownDTO(string value, string text)
        {
            Value = value;
            Text = text;
        }
    }
