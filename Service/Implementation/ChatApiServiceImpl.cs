using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NistagramSQLConnection.Model;
using NistagramSQLConnection.Service;
using NistagramUtils.DTO.Chat;

namespace NistagramChatAPI.Service.Implementation
{
    public class ChatApiServiceImpl : IChatApiService
    {

        private readonly IChatService _iChatService;
        private readonly IMapper _mapper;

        public ChatApiServiceImpl(IChatService iChatService, IMapper mapper)
        {
            _iChatService = iChatService;
            _mapper = mapper;
        }

        public List<Message> GetChatByUser(long friendId, long userId)
        {
            List<Message> messages = _iChatService.GetChatByUser(friendId, userId);
            return messages;
        }

        public Message SendMessage(SendMessageDto sendMessageDto)
        {
            Message message = _iChatService.SendMessage(sendMessageDto.text, sendMessageDto.friendId, sendMessageDto.userId);
            return message;
        }
    }
}
