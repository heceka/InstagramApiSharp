namespace Blockout2024.Models
{
    internal class InstagramUser
    {
        internal string UserName { get; set; }
        internal string FullName { get; set; }

        public override string ToString()
        {
            return $"{UserName} /*\\ {FullName}";
        }
    }
}
