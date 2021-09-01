using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NistagramChatAPI.Service;
using NistagramSQLConnection.Model;
using NistagramUtils.DTO.Chat;

namespace NistagramChatAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {

        private readonly IChatApiService _iChatApiService;
        private readonly IMapper _mapper;

        public ChatController(IChatApiService iChatApiService, IMapper mapper)
        {
            _iChatApiService = iChatApiService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[action]")]
        public Object GetChatByUser(long friendId, long userId)
        {
            List<Message> messages = _iChatApiService.GetChatByUser(friendId, userId);
            return JsonConvert.SerializeObject(messages);
        }

        [HttpPost]
        [Route("/[action]")]
        public Object SendMessage(SendMessageDto sendMessageDto)
        {
            Message message = _iChatApiService.SendMessage(sendMessageDto);
            return JsonConvert.SerializeObject(message);
        }
    }
}
