using CheckThisData.Models;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CheckThisData.Managers
{
    public class CheckThisListsManager :  ICheckThisListsManager
    {
        private readonly MongoRepository<CheckThisList> _mongoProvider;

        public CheckThisListsManager()
        {
            //mongodb+srv://gymbratjodee:checkthisservice@cluster0-p0lw4.mongodb.net/test
            // mongodb://r1.example.net:27017,r2.example.net:27017/
            _mongoProvider = new MongoRepository<CheckThisList>("mongodb://gymbratjodee:checkthisservice@cluster0-p0lw4.mongodb.net:27017/admin");
            //TODO - repo injection, custom connection string?
        }

        public long CountListsTest()
        {
            var count = _mongoProvider.Count();
            return count;
        }

        public async Task<List<CheckThisList>> GetListsByPerson(long personId)
        {
            //TOTO - use MongoRepo once connection string issue is resolved and driver 2.0 installed with async!
            return await Task.Run(() =>
            {
                return new List<CheckThisList>()
                {
                    new CheckThisList()
                    {
                        Id = "5a62bc998553192c2833ad90",
                        CreatedDate = Convert.ToDateTime("1/15/17"),
                        ListName = "House TODO",
                        PersonId = personId,
                        KeyWords = new List<String>()
                        {   "DIY home repair",
                            "xeriscape",
                            "install pet door",
                            "custom fence gates"
                        },
                        ListType = ListTypes.Action,
                        PhotoId = "5a62bc998553192c2833ad9",
                        Items = new List<ListItem>()
                        {
                            new ListItem()
                            {
                                ItemName = "Stain deck",
                                SortOrder = 3,
                                CreatedDate = Convert.ToDateTime("9/2/17")
                            },
                            new ListItem()
                            {
                                ItemName = "Gate lock",
                                DueDate = Convert.ToDateTime("1/22/18"),
                                Notes = "Extend deadbolt to 2 3/4 and dremel out new fence board",
                                SortOrder = 1,
                                CreatedDate = Convert.ToDateTime("6/7/17")
                            },
                            new ListItem()
                            {
                                ItemName = "Stain fence",
                                SortOrder = 2,
                                CreatedDate = Convert.ToDateTime("7/8/16")
                            }
                        }
                    },
                    new CheckThisList()
                    {
                        Id = "5a63c1098553192c2833ad94",
                        CreatedDate = Convert.ToDateTime("6/3/17"),
                        ListName = "Hikes",
                        PersonId = personId,
                        KeyWords = new List<String>()
                        {   "Southern California Hikes",
                            "Best hikes for fall leaves",
                            "Waterfalls"
                        },
                        ListType = ListTypes.Interest,
                        Items = new List<ListItem>()
                        {
                            new ListItem()
                            {
                                ItemName = "Bridge to Nowhere",
                                Notes = @"https://socalhiker.net/hike-the-bridge-to-nowhere/",
                                CreatedDate = Convert.ToDateTime("3/6/17"),
                                DidItDate = Convert.ToDateTime("6/7/17"),
                                PhotoId = "A26F11C5-455F-4D73-AB94-01CB23062DFB"
                            },
                            new ListItem()
                            {
                                ItemName = "3 sisters",
                                CreatedDate = Convert.ToDateTime("6/7/17")
                            }
                        }
                    }
                };
            });

            //return Task.FromResult(result);
        }
    }

    public interface ICheckThisListsManager
    {
        Task<List<CheckThisList>> GetListsByPerson(long personId);
    }
}
