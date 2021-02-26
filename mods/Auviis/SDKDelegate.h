#ifndef SDKDelegate_h
#define SDKDelegate_h
#include <iostream>
#include <string>
#include <vector>
#import "auviis.hpp"
#import <UIKit/UIKit.h>

class SDKDelegate{
public:
    SDKDelegate();
    ~SDKDelegate();
public:
    static SDKDelegate *getInstance();
public:
    void init();
    void onInitSuccess(int64_t peer_id);
    void onActivated(int64_t peer_id);
    void onError(int code, std::string reason);
    void onDisconnect(int code, std::string reason);
    void onJoinChannel(int code, int64_t channel_id, int64_t member_count, std::string msg);
    void onReceiveChannelMembers(int64_t channel_id, std::vector<int64_t> peers);
    void onTextMessage(int64_t sender_id, int64_t channel_id, std::string msg);
    void onVoiceMessage(int64_t sender_id, int64_t channel_id, std::string msg_id);
    void onVoiceMessageReady(int code, long record_id);
protected:
    static SDKDelegate *_server_handle;
public:
    void updateChatContent(NSString *txt);
    void setOneClick(bool a){ oneclick = a;}
private:
    bool oneclick = false;
};


#endif /* SDKDelegate_h */
