using System.Collections.Generic;
using NistagramSQLConnection.Model;
using NistagramUtils.DTO.Chat;

namespace NistagramChatAPI.Service
{
    public interface IChatApiService
    {
        List<Message> GetChatByUser(long friendId, long userId);
        Message SendMessage(SendMessageDto sendMessageDto);
    }
}
