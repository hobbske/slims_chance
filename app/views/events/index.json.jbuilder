json.array!(@events) do |event|
  json.extract! event, :id, :start_date, :end_date, :start_time, :end_time, :event_name, :event_desc, :cost
  json.url event_url(event, format: :json)
end
