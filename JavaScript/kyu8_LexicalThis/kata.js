let Person = () =>  {
    return {
        _name: 'bq666',
        _friends: [],
        fillFriends: function (f) {
            this._friends.push(...f)
        }
    }
}
