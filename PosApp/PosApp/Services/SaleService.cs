using PosApp.Model;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PosApp.Services
{
    class SaleService : INotifyPropertyChanged
    {
        public ObservableCollection<AnimalModel> AnimalModels { get; private set; } = new ObservableCollection<AnimalModel>();

        public SaleService()
        {
            tapcommand = new Command<AnimalModel>(OnTap);
            AddBears();
        }
        #region command
        public void OnTap(AnimalModel animalModel)
        {
            Application.Current.MainPage.Navigation.PushPopupAsync(new SalesDetailPopUp(animalModel), true);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand tapcommand { get; private set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        void AddBears()
        {
            AnimalModels.Add(new AnimalModel
            {
                Name = "Card Payment",
                Location = "Gulshan Branch",
                Details = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.",
                ImageUrl = "card1.png",
                Price = "৳250",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The Asian black bear, also known as the moon bear and the white-chested bear, is a medium-sized bear species native to Asia and largely adapted to arboreal life. It lives in the Himalayas, in the northern parts of the Indian subcontinent, Korea, northeastern China, the Russian Far East, the Honshū and Shikoku islands of Japan, and Taiwan. It is classified as vulnerable by the International Union for Conservation of Nature (IUCN), mostly because of deforestation and hunting for its body parts.",
                ImageUrl = "cash1.png",
                Price = "৳350",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Card Payment",
                Location = "Gulshan Branch",
                Details = "The brown bear is a bear that is found across much of northern Eurasia and North America. In North America the population of brown bears are often called grizzly bears. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly larger on average. The brown bear's principal range includes parts of Russia, Central Asia, China, Canada, the United States, Scandinavia and the Carpathian region, especially Romania, Anatolia and the Caucasus. The brown bear is recognized as a national and state animal in several European countries.",
                ImageUrl = "card1.png",
                Price = "৳240",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Card Payment",
                Location = "Gulshan Branch",
                Details = "A grizzly–polar bear hybrid is a rare ursid hybrid that has occurred both in captivity and in the wild. In 2006, the occurrence of this hybrid in nature was confirmed by testing the DNA of a unique-looking bear that had been shot near Sachs Harbour, Northwest Territories on Banks Island in the Canadian Arctic. The number of confirmed hybrids has since risen to eight, all of them descending from the same female polar bear.",
                ImageUrl = "card1.png",
                Price = "৳560",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The sloth bear is an insectivorous bear species native to the Indian subcontinent. It is listed as Vulnerable on the IUCN Red List, mainly because of habitat loss and degradation. It has also been called labiated bear because of its long lower lip and palate used for sucking insects. Compared to brown and black bears, the sloth bear is lankier, has a long, shaggy fur and a mane around the face, and long, sickle-shaped claws. It evolved from the ancestral brown bear during the Pleistocene and through convergent evolution shares features found in insect-eating mammals.",
                ImageUrl = "cash1.png",
                Price = "৳1240",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The sun bear is a bear species occurring in tropical forest habitats of Southeast Asia. It is listed as Vulnerable on the IUCN Red List. The global population is thought to have declined by more than 30% over the past three bear generations. Suitable habitat has been dramatically reduced due to the large-scale deforestation that has occurred throughout Southeast Asia over the past three decades. The sun bear is also known as the honey bear, which refers to its voracious appetite for honeycombs and honey.",
                ImageUrl = "cash1.png",
                Price = "৳9042",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals.",
                ImageUrl = "cash1.png",
                Price = "৳2312",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Card Payment",
                Location = "Gulshan Branch",
                Details = "The spectacled bear, also known as the Andean bear or Andean short-faced bear and locally as jukumari (Aymara), ukumari (Quechua) or ukuku, is the last remaining short-faced bear. Its closest relatives are the extinct Florida spectacled bear, and the giant short-faced bears of the Middle to Late Pleistocene age. Spectacled bears are the only surviving species of bear native to South America, and the only surviving member of the subfamily Tremarctinae. The species is classified as Vulnerable by the IUCN because of habitat loss.",
                ImageUrl = "card1.png",
                Price = "৳456",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The short-faced bears is an extinct bear genus that inhabited North America during the Pleistocene epoch from about 1.8 Mya until 11,000 years ago. It was the most common early North American bear and was most abundant in California. There are two recognized species: Arctodus pristinus and Arctodus simus, with the latter considered to be one of the largest known terrestrial mammalian carnivores that has ever existed. It has been hypothesized that their extinction coincides with the Younger Dryas period of global cooling commencing around 10,900 BC.",
                ImageUrl = "cash1.png",
                Price = "৳346",
                Date = "2/1/2019"
            });
            AnimalModels.Add(new AnimalModel
            {
                Name = "Cash Payment",
                Location = "Gulshan Branch",
                Details = "The California grizzly bear is an extinct subspecies of the grizzly bear, the very large North American brown bear. Grizzly could have meant grizzled (that is, with golden and grey tips of the hair) or fear-inspiring. Nonetheless, after careful study, naturalist George Ord formally classified it in 1815 – not for its hair, but for its character – as Ursus horribilis (terrifying bear). Genetically, North American grizzlies are closely related; in size and coloring, the California grizzly bear was much like the grizzly bear of the southern coast of Alaska. In California, it was particularly admired for its beauty, size and strength. The grizzly became a symbol of the Bear Flag Republic, a moniker that was attached to the short-lived attempt by a group of American settlers to break away from Mexico in 1846. Later, this rebel flag became the basis for the state flag of California, and then California was known as the Bear State.",
                ImageUrl = "cash1.png",
                Price = "৳900",
                Date = "2/1/2019"
            });
        }
    }
}
