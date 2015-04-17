using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Artists;
using Saga.Specification.Interfaces.Audio;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Tags;
using Saga.Specification.Interfaces.Users;
using Saga.Specifications.Interfaces.Parts;

namespace Saga.Dal
{
    public class UserRepository : IUserRepository
    {
        public UserRepository (IGenreRepository genreRepo, ITrackRepository trackRepo, IArtistRepository artistRepo, IPartRepository partRepo, ITagRepository tagRepo)
        {

        }

        public void DarwinPercentage_Set(ISettings settings, int percentage)
        {
            throw new NotImplementedException();
        }

        public double[] DarwinRange_Get(IUser user)
        {
            throw new NotImplementedException();
        }

        public double DarwinScore_Get(IUser user, Specification.Interfaces.Audio.ITrack track)
        {
            throw new NotImplementedException();
        }

        public void DarwinScore_Set(IUser currentUser, Specification.Interfaces.Audio.ITrack audioToSkip, double newDarwinScore)
        {
            throw new NotImplementedException();
        }

        public void DarwinThreshold_Save(ISettings settings)
        {
            throw new NotImplementedException();
        }

        public void ExcludedArtistSetting_Add(ISettings settings, Specification.Interfaces.Artists.IArtist artistToExclude)
        {
            throw new NotImplementedException();
        }

        public void ExcludedArtistSetting_Remove(ISettings settings, Specification.Interfaces.Artists.IArtist artistToRemove)
        {
            throw new NotImplementedException();
        }

        public void ExcludedGenresSetting_Add(ISettings settings, Specification.Interfaces.Genres.IGenre genreToExclude)
        {
            throw new NotImplementedException();
        }

        public void ExcludedGenresSetting_Remove(ISettings settings, Specification.Interfaces.Genres.IGenre genreToRemove)
        {
            throw new NotImplementedException();
        }

        public void ExcludedPartsSetting_Add(ISettings settings, Specification.Interfaces.IPartBase partToExclude)
        {
            throw new NotImplementedException();
        }

        public void ExcludedPartsSetting_Remove(ISettings settings, Specification.Interfaces.IPartBase partToRemove)
        {
            throw new NotImplementedException();
        }

        public void ExcludedSlideShowTagSetting_Add(ISettings settings, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }

        public void ExcludedSlideShowTagSetting_Remove(ISettings settings, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }

        public IUser Get(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IUser Get(int userId)
        {
            throw new NotImplementedException();
        }

        public IList<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public int? Grade_Get(IUser user, Specification.Interfaces.Audio.ITrack t)
        {
            throw new NotImplementedException();
        }

        public void IncludedArtistSetting_Add(ISettings settings, Specification.Interfaces.Artists.IArtist artistToAttach)
        {
            throw new NotImplementedException();
        }

        public void IncludedArtistSetting_Remove(ISettings settings, Specification.Interfaces.Artists.IArtist artistToUnattach)
        {
            throw new NotImplementedException();
        }

        public void IncludedGenresSetting_Add(ISettings settings, Specification.Interfaces.Genres.IGenre genreToAttach)
        {
            throw new NotImplementedException();
        }

        public void IncludedGenresSetting_Remove(ISettings settings, Specification.Interfaces.Genres.IGenre genreToUnattach)
        {
            throw new NotImplementedException();
        }

        public void IncludedPartsSetting_Add(ISettings settings, Specification.Interfaces.IPartBase partToAttach)
        {
            throw new NotImplementedException();
        }

        public void IncludedPartsSetting_Remove(ISettings settings, Specification.Interfaces.IPartBase partToUnattach)
        {
            throw new NotImplementedException();
        }

        public void IncludedSlideShowTagSetting_Add(ISettings settings, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }

        public void IncludedSlideShowTagSetting_Remove(ISettings settings, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }

        public void NoRepeat_Save(ISettings settings)
        {
            throw new NotImplementedException();
        }

        public void Played(int userId, int mediaId)
        {
            throw new NotImplementedException();
        }

        public void Played(IUser user, Specification.Interfaces.IMedia media)
        {
            throw new NotImplementedException();
        }

        public Specification.Interfaces.Audio.ITrack RandomAudioTrack_Get(int userId)
        {
            throw new NotImplementedException();
        }

        public void RecentlyPlayedMedia_Clear(IUser user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Specification.Interfaces.IMedia> RecentlyPlayedMedia_Get(IUser user)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Audio.ITrack> RecentlyPlayedTracks_Get(IUser user)
        {
            throw new NotImplementedException();
        }

        public void Settings_PromptForMissingDarwin_Save(ISettings settings, bool teachMeDarwin)
        {
            throw new NotImplementedException();
        }

        public void Settings_PromptForMissingGenres_Save(ISettings settings, bool teachMeGenres)
        {
            throw new NotImplementedException();
        }

        public void Settings_PromptForMissingParts_Save(ISettings settings, bool teachMeParts)
        {
            throw new NotImplementedException();
        }
    }
}
