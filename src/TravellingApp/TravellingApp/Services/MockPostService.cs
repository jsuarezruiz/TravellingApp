using System.Collections.Generic;
using TravellingApp.Models;

namespace TravellingApp.Services
{
    public class MockPostService
    {
        private static MockPostService _instance;

        public static MockPostService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MockPostService();
                return _instance;
            }
        }

        public List<Post> GetCommunityPosts()
        {
            return new List<Post>
            {
                new Post { Title = "Keala Redefines Women's Surf", SubTitle = "Stories from the Road Pt 2", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "surf.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-surfer-life-1561052053317.mp4" },
                new Post { Title = "Artist Spotlight Story", SubTitle = "Artist Spotlight with Cayucas", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "guitar.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2FStrum-Away.mp4" },
                new Post { Title = "Best new food experiences", SubTitle = "Best new food experiences", Date = "JULY 23, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "hamburguer.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-girl-eats-pizza-1563957998818.mp4" },
                new Post { Title = "Keala Redefines Women's Surf", SubTitle = "Stories from the Road Pt 2", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "surf.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-surfer-life-1561052053317.mp4" },
                new Post { Title = "Artist Spotlight Story", SubTitle = "Artist Spotlight with Cayucas", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "guitar.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2FStrum-Away.mp4" },
                new Post { Title = "Best new food experiences", SubTitle = "Best new food experiences", Date = "JULY 23, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "hamburguer.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-girl-eats-pizza-1563957998818.mp4" },
                new Post { Title = "Keala Redefines Women's Surf", SubTitle = "Stories from the Road Pt 2", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "surf.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-surfer-life-1561052053317.mp4" },
                new Post { Title = "Artist Spotlight Story", SubTitle = "Artist Spotlight with Cayucas", Date = "JULY 24, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "guitar.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2FStrum-Away.mp4" },
                new Post { Title = "Best new food experiences", SubTitle = "Best new food experiences", Date = "JULY 23, 2015", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Image = "hamburguer.jpg", Video = "https://storage.googleapis.com/coverr-main/mp4%2Fcoverr-girl-eats-pizza-1563957998818.mp4" }
            };
        }
    }
}