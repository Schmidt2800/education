using MicroServiceEduOrder.Application.Mappers;
using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Domain.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace MicroServiceEduOrder.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IOrderDtoMapper _OrderDtoMapper;
        private readonly HttpClient _Client;
        public OrderService(IOrderRepository orderRepository, IOrderDtoMapper orderDtoMapper)
        {
            _OrderRepository = orderRepository;
            _OrderDtoMapper = orderDtoMapper;
            _Client = new HttpClient();
        }
        public OrderDto Create(OrderDto orderDto)
        {
            var order = _OrderDtoMapper.Create(orderDto);
            var createdOrder = _OrderRepository.CreateOrder(order);
            createdOrder.Products = orderDto.Products; //Dirty hack
            GenerateDocument(createdOrder);
            return _OrderDtoMapper.Map(createdOrder);
        }

        public OrderDto Get(int orderId)
        {
            var order = _OrderRepository.GetOrder(orderId);
            return _OrderDtoMapper.Map(order);
        }
        private async void GenerateDocument(IOrder order)
        {
            //string customerURL = $"http://microserviceeducustomer/Customer/{order.CustomerId}";
            string customerURL = $"https://localhost:44371/Customer/{order.CustomerId}";
            var customer = await _Client.GetStringAsync(customerURL);
            //string productURL = $"http://microserviceeduproductcatalog/Product/{order.CustomerId}";
            List<string> products = new List<string>();
            foreach (var productId in order.Products)
            {
            string url = $"https://localhost:44381/Product/{productId}";

                var productJson = await _Client.GetStringAsync(url);
                products.Add(productJson);
                var priceToken = JObject.Parse(productJson).SelectToken("$.price");
                order.TotalAmount += Convert.ToDecimal(priceToken.ToString());
            }

            //JObject custObject = JObject.Parse(customer);

            //JObject jsonOrder = new JObject();
            //jsonOrder.Add("orderNo", order.OrderNo);
            //jsonOrder.Add("customerNo", custObject.SelectToken("$.id"));
            //var custName = custObject.SelectToken("$.firstName").ToString() + " " + custObject.SelectToken("$.lastName").ToString();
            //jsonOrder.Add("customerName", custName);
            //HttpRequestMessage requestMessage = new HttpRequestMessage();

            //requestMessage.Method = HttpMethod.Post;
            //requestMessage.RequestUri = new System.Uri("http://microserviceedudocumentgenerator/Document");
            //requestMessage.Content = new StringContent(jsonOrder.ToString(), System.Text.Encoding.UTF8, "application/json");


            //var result = _Client.Send(requestMessage);


        }
    }
}
