using PerpustakaanAppMVC.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class MahasiswaRestApiRepo
    {
        public int Create(Mahasiswa mhs)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            var client = new RestClient(baseUrl);

            var req = new RestRequest(endpoint, Method.Post);

            req.AddJsonBody(mhs);

            var res = client.Execute(req);

            var result = res.Content.IndexOf("1") > 0 ? 1 : 0;

            return result;
        }

        public int Update(Mahasiswa mhs)
        {
            throw new NotImplementedException();
        }

        public int Delete(Mahasiswa mhs)
        {
            throw new NotImplementedException();
        }

        public List<Mahasiswa> ReadAll()
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.Get);

            // kirim request ke server
            var response = client.Execute<List<Mahasiswa>>(request);

            return response.Data;
        }

        public List<Mahasiswa> ReadByNama(string nama)
        {
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = $"api/mahasiswa?nama={nama}";

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.Get);

            // kirim request ke server
            var response = client.Execute<List<Mahasiswa>>(request);

            return response.Data;
        }

        public Mahasiswa ReadByNpm(string npm)
        {
            throw new NotImplementedException();
        }
    }
}
