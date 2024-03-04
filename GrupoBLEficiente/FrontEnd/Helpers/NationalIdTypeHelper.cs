using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class NationalIdTypeHelper
    {
        ServiceRepository repository;

        public NationalIdTypeHelper()
        {
            repository = new ServiceRepository();
        }

        #region GetAll
        public List<NationalIdTypeViewModel> GetAll()
        {
            List<NationalIdTypeViewModel> entities = new List<NationalIdTypeViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/NationalIdType/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                entities = JsonConvert.DeserializeObject<List<NationalIdTypeViewModel>>(content);
            }
            return entities;
        }
        #endregion

        #region GetByID
        public NationalIdTypeViewModel GetByID(int id)
        {
            NationalIdTypeViewModel entity = new NationalIdTypeViewModel();
            HttpResponseMessage responseMessage = repository.GetResponse("api/NationalIdType/" + id);
            string content = responseMessage.Content.ReadAsStringAsync().Result;
            entity = JsonConvert.DeserializeObject<NationalIdTypeViewModel>(content);
            return entity;
        }
        #endregion

        #region Update
        public NationalIdTypeViewModel Edit(NationalIdTypeViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/NationalIdType/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            NationalIdTypeViewModel entityAPI = JsonConvert.DeserializeObject<NationalIdTypeViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Create
        public NationalIdTypeViewModel Add(NationalIdTypeViewModel entity)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/NationalIdType/", entity);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            NationalIdTypeViewModel entityAPI = JsonConvert.DeserializeObject<NationalIdTypeViewModel>(content);
            return entityAPI;
        }
        #endregion

        #region Delete
        public NationalIdTypeViewModel Delete(int id)
        {
            NationalIdTypeViewModel entity = new NationalIdTypeViewModel();
            HttpResponseMessage responseMessage = repository.DeleteResponse("api/NationalIdType/" + id);
            return entity;
        }
        #endregion
    }
}